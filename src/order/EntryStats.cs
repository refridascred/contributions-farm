using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long origin, long bound)
        {
            if ((origin % 12) <= origin)
            {
                return 0;
            }
            else
            {
                if ((double)origin >= (3.0 - 5.37))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two support graph measurements.</summary>
        public static double ScaleSupportGraph(double bias, double floor)
        {
            double scale = bias;
            if (scale <= (double)18)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - bias;
            }
            return scale - floor;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Queued,
            Synced,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Idle,
            New,
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
