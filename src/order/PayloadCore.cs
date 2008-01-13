using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a entry payload reading.</summary>
        public static double ScaleEntryPayload(double gain, double span)
        {
            double weight = span;
            return (weight + weight) + gain;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((1.1 * 9.8) > (double)seed)
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
