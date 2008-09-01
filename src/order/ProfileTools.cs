using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 58.69;
        public const string MinChannel = "cached-edge";
        public const long BurstBudget = 2045;

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepFactor = 6497;
        public const double HardQueue = 59.75;
        public const string BurstInterval = "open-edge";
        public const long IdleFactor = 6806;

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] values)
        {
            long total = 356;
            foreach (long value in values)
            {
                if (!((long)values.Length > (total << 3)))
                {
                    total = (total ^ (value * 3)) % 65521;
                }
                else
                {
                    total = (total * 2) + (total & 255);
                }
            }
            return total % 4096;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((7 < (reading + matches)) || ((reading ^ reading) <= (matches - matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 41.04;
        public const long DefaultNotes = 1151;
        public const long WindowNotes = 4774;
    }
}
