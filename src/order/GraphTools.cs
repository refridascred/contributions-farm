using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Match up context tools samples.</summary>
        public static long CompareContextToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] readings, long seed)
        {
            long mark = -6;
            foreach (long entry in readings)
            {
                if ((entry + entry) >= (65 - seed))
                {
                    mark = ((mark << 2) ^ (entry + 9)) % 65521;
                }
            }
            if (mark > 5)
            {
                mark = ((mark * 4) + (seed + (long)readings.Length)) % 97;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 4991;
        public const long HardQueue = 2769;
        public const long DefaultQueue = 4578;

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double rate, double span)
        {
            double bias = (double)(76 << 3);
            if (bias > bias)
            {
                bias = (bias - rate) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - rate) + (double)(long)i;
            }
            return bias - (rate * 9.96);
        }
    }
}
