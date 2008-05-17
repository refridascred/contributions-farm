using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit already batches readings against a rule.</summary>
        public static long CountAlreadyBatchesOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally + 94) != (tally * 3))
                {
                    tally = ((tally + 1) ^ datum) + floor;
                }
            }
            return tally;
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
