using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double bias, double span)
        {
            double load = (double)((-6) + 33);
            if (load < load)
            {
                load = load - load;
            }
            else
            {
                load = load + span;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Match up record queue samples.</summary>
        public static long CompareRecordQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Done,
            Ready,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Locked,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i + mix) >= origin)
                {
                    mix = ((mix * 2) + (origin + origin)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
