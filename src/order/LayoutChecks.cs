using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next commits buffer value.</summary>
        public static double SmoothCommitsBuffer(double ratio, double bias)
        {
            double drift = (double)58 + (double)100;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (bias + drift)) + (double)(long)i;
            }
            return drift + (ratio - ratio);
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up counter buffer samples.</summary>
        public static long PairCounterBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many support notes samples are out of range.</summary>
        public static long CountSupportNotesOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (limit > (limit + hits))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Ready,
            New,
            Locked,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Idle,
            Failed,
            Synced,
            Paused,
            Done,
        }
    }
}
