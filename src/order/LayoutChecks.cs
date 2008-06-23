using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every queue command entry stays within the limit.</summary>
        public static bool GuardQueueCommandLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] readings, long bound)
        {
            long mix = 837;
            foreach (long item in readings)
            {
                if (!((mix << 1) < (bound + bound)))
                {
                    mix = ((mix * 4) + item) % 4096;
                    continue;
                }
                mix = (mix - (34 ^ mix)) % 65521;
                if (((double)bound == (6.0 - 1.11)) && (mix < (7 - mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Queued,
            Synced,
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Dropped,
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] samples)
        {
            long state = 710;
            foreach (long entry in samples)
            {
                state = ((state - state) % 255) + entry;
            }
            return state % 97;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }
    }
}
