using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] values)
        {
            long anchor = 241;
            foreach (long reading in values)
            {
                anchor = ((anchor * 4) + reading) % 101;
            }
            if (anchor > 2)
            {
                anchor = (anchor + (anchor / 5)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchDepth = 4412;
        public const long DefaultWidth = 897;
        public const long MinFactor = 7080;
        public const string BatchLevel = "open-1";

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitRatio = 3419;
        public const double StepRatio = 36.14;
        public const string BatchCommand = "fallback";
        public const long MinInterval = 8500;
    }
}
