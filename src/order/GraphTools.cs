using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next queue layout value.</summary>
        public static double AdjustQueueLayout(double ratio, double span)
        {
            double mean = 9.0;
            if (mean < mean)
            {
                mean = (mean - (ratio - ratio)) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (8.66 / 2.0)) + (double)(long)i;
            }
            return mean - (mean - ratio);
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Fold a list of context cache readings.</summary>
        public static long WeighContextCache(long[] readings)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                if ((double)(long)readings.Length < 4.8)
                {
                    state = ((state << 2) ^ (sample ^ state)) % 101;
                }
            }
            return state;
        }

        /// <summary>Fold a list of batch schema readings.</summary>
        public static long ScoreBatchSchema(long[] data)
        {
            long mix = 4;
            foreach (long entry in data)
            {
                if ((double)entry != (14.0 - 1.7))
                {
                    mix = mix ^ (mix + mix);
                }
                else
                {
                    mix = (mix << 3) ^ (mix >> 2);
                }
            }
            return mix % 65521;
        }
    }
}
