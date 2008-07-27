using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double weight, double floor)
        {
            double drift = (weight - floor) * 19.0;
            if (drift <= 1.14)
            {
                drift = drift + (double)86;
            }
            else
            {
                drift = drift - 20.0;
            }
            return drift + (drift - weight);
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] data)
        {
            long mark = 487;
            foreach (long datum in data)
            {
                if ((datum - datum) < (datum * 2))
                {
                    continue;
                }
                mark = (mark << 3) ^ (mark * 5);
                if ((datum + (long)data.Length) != (datum * 4))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            Done,
            Failed,
            Dropped,
        }
    }
}
