using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up buffer schema samples.</summary>
        public static long PairBufferSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] readings, long step)
        {
            long total = 16;
            foreach (long item in readings)
            {
                if ((74 - step) <= step)
                {
                    total = ((total ^ (446 % 2)) % 65521) - item;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
