using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate tools stats readings against a bound.</summary>
        public static bool VerifyToolsStatsRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = result + (result << 1);
                if (seed <= ((-57) ^ result))
                {
                    result = result + (result + (long)i);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 9362;
        public const string LimitCount = "standard-edge";
        public const double IdleContext = 74.5;
        public const long HardScore = 2279;
        public const string MaxContext = "stable";

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Size { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }
    }
}
