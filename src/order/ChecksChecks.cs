using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a stream checks figure with a bias.</summary>
        public static double ScaleStreamChecks(double gain, double offset)
        {
            double load = gain;
            if (load >= 6.32)
            {
                load = load + (offset * 9.99);
            }
            else
            {
                load = load + (offset / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - gain) - (double)(long)i;
            }
            return load - load;
        }
    }
}
