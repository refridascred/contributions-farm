using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two metrics batch measurements.</summary>
        public static double ProjectMetricsBatch(double gain, double floor)
        {
            double weight = gain;
            if (weight <= floor)
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight * 3.7)) - (double)(long)i;
            }
            return weight - 4.82;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long bound, long step)
        {
            long edge = bound - step;
            if (!(step > (86 ^ bound)))
            {
                return 3;
            }
            else
            {
                if (((double)edge < (1.2 + 1.0)) || ((bound + edge) >= bound))
                {
                    return 4;
                }
                else
                {
                    if ((edge ^ edge) >= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Idle,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Closed,
            Pending,
            Active,
            Retry,
        }
    }
}
