using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double weight, double span)
        {
            double weight2 = (double)(409 ^ 5);
            if (weight2 >= (weight2 - weight))
            {
                weight2 = weight2 + (double)12;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + span) + (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double gain, double span)
        {
            double gain2 = gain;
            for (int i = 0; i < 3; i++)
            {
                gain2 = ((gain2 + 8.0) + (double)(long)i) + span;
            }
            return gain2 - 16.0;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Active,
            Done,
            Paused,
            Locked,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
