using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandPass {
	public class PassGenerator {
		#region Private members

		private Random _randNbr { get; set; }
		private char[] _uppercaseChars = new char[]  { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
		private char[] _lowercaseChars = new char[]  { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
		private char[] _numeralChars = new char[]    { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the password generator, with a time-dependent value used as the
		/// pseudo-random number generator's seed (see the System.Random class constructor).
		/// </summary>
		public PassGenerator() {
			_randNbr = new Random();
		}

		/// <summary>
		/// Initializes a new instance of the password generator, with the specified integer value used as
		/// the pseudo-random number generator's seed (see the System.Random class constructor).
		/// </summary>
		/// <param name="seed"></param>
		public PassGenerator(int seed) {
			_randNbr = new Random(seed);
		}

		#endregion

		#region Public methods

		/// <summary>
		/// Generates a random password according to the specified parameters.
		/// </summary>
		/// <param name="length">The leangth of the password to generate.</param>
		/// <param name="includeCaps">Whether to include capital letters in the password.</param>
		/// <param name="includeLowers">Whether to include lowercase letters in the password.</param>
		/// <param name="includeNumerals">Whether to include numerals in the password.</param>
		/// <returns>The generated password.</returns>
		public string GeneratePassword(uint length, bool includeCaps, bool includeLowers, bool includeNumerals) {
			StringBuilder sbPass = new StringBuilder();
			List<char> availableChars = new List<char>();

			if (length == 0) {
				throw new Exception("Specified password length must be above zero.");
			}
			if (!includeCaps && !includeLowers && !includeNumerals) {
				throw new Exception("Must include at least one of caps, lowers, or numerals in password.");
			}

			if (includeCaps) {
				availableChars.AddRange(_uppercaseChars);
			}
			if (includeLowers) {
				availableChars.AddRange(_lowercaseChars);
			}
			if (includeNumerals) {
				availableChars.AddRange(_numeralChars);
			}

			for (uint i=0; i < length; i++) {
				// eg. _randNbr.Next(0, 3) will return a number between 0-2 (upper bound of 3 is exclusive)
				sbPass.Append(availableChars[_randNbr.Next(0, availableChars.Count)]);
			}

			return sbPass.ToString();
		}

		#endregion
	}
}
