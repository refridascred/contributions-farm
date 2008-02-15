using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double bias, double bias2)
        {
            double load = bias;
            if (load >= (bias2 + load))
            {
                load = load + (double)5;
            }
            else
            {
                load = load - (double)67;
            }
            return load - (load - bias2);
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Retry,
            Locked,
        }

        /// <summary>Match up contributi format samples.</summary>
        public static long MatchContributiFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seed <= (value - (-375))) || ((13.0 - 14.0) != (double)seed))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
