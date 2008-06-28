using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Score { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            New,
            Synced,
        }
    }
}
