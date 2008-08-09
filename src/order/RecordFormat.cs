using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double gain, double bias)
        {
            double rate = bias;
            if (rate >= bias)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + gain) - (double)(long)i;
            }
            return rate - (rate - gain);
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstRatio = 349;
        public const string StepTimeout = "stable";
        public const string CacheAlready = "staging";
        public const long MaxAlready = 681;

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                state = state ^ (long)i;
                if ((53 / 6) <= (seed + seed))
                {
                    break;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
