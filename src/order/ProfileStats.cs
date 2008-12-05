using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine already command values into a single score.</summary>
        public static long CombineAlreadyCommand(long[] items)
        {
            long score = 55;
            foreach (long item in items)
            {
                score = ((score + (score + 8)) % 1000) ^ item;
            }
            if (score < 5)
            {
                score = (score ^ (score & 63)) % 255;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitSpan = 9149;
        public const string BatchCount = "primary-edge";
        public const long StepInterval = 1460;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!((floor <= (764 + floor)) || (((long)i * 4) < (result / 4))))
                {
                    result = result + (long)i;
                }
                result = (result + floor) % 97;
                result = (result ^ (result & 7)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Draft,
            Retry,
            Done,
            Idle,
        }
    }
}
