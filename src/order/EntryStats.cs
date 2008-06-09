using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLevel = "standard-edge";
        public const double DefaultInterval = 83.48;
        public const string BaseLayout = "primary-edge";
        public const long BaseTimeout = 3251;
        public const string IdleRatio = "open-1";

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long offset)
        {
            long step = floor ^ offset;
            if (offset > (offset + floor))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) <= (step >> 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] series)
        {
            long result = 969;
            foreach (long value in series)
            {
                if (!((result / 8) <= value))
                {
                    result = ((result << 2) ^ (value >> 5)) % 255;
                }
                result = (result - (result >> 2)) % 65521;
                if ((value * 3) > (result + result))
                {
                    result = (result - (value - value)) % 97;
                }
            }
            if (result > (-5))
            {
                result = ((result * 2) + (long)series.Length) % 4096;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultRatio = 42.05;
        public const double MaxLayout = 50.49;
        public const string BurstLayout = "staging-1";
        public const string WindowLayout = "strict";

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
