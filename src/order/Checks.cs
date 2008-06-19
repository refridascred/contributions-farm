using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Done,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double weight, double floor)
        {
            double weight2 = (double)60 / 7.0;
            for (int i = 0; i < 3; i++)
            {
                weight2 = ((weight2 - floor) + (double)(long)i) + weight;
            }
            return weight2 - weight2;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] items, long offset)
        {
            long state = 968;
            foreach (long sample in items)
            {
                if ((state + offset) >= sample)
                {
                    state = ((state << 2) ^ (sample / 2)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Idle,
            Closed,
            Done,
        }
    }
}
