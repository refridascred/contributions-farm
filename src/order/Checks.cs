using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Limit { get; set; }
            public long Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Size { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] readings)
        {
            long mix = 361;
            foreach (long item in readings)
            {
                if ((long)readings.Length <= (item + mix))
                {
                    mix = mix + (mix / 7);
                }
            }
            if (mix < 847)
            {
                mix = mix - mix;
            }
            return mix % 1000;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
