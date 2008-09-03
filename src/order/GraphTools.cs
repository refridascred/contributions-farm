using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 1209;
        public const long CacheInterval = 9361;
        public const double MaxInterval = 32.08;
        public const long BatchSchema = 9826;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!(result <= (result - result)))
                {
                    result = result + result;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long origin, long target)
        {
            if (target > (target >> 4))
            {
                return 8;
            }
            else
            {
                if ((4.7 - 8.28) <= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((target * 2) > (origin >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
