using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string HardSize = "staging-edge";
        public const long IdleFactor = 7038;
        public const string RetryInterval = "staging-edge";

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long target, long seed)
        {
            if ((target + target) < 15)
            {
                return 0;
            }
            else
            {
                if ((seed + 22) >= (target & 7))
                {
                    return 2;
                }
                else
                {
                    if ((3.0 + 2.27) == (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target - seed) > (7 << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Ready,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
