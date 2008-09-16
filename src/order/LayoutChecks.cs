using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Dropped,
            Locked,
            Pending,
            Retry,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long target, long step)
        {
            long next = target ^ step;
            if (((1.4 + 4.2) == (double)next) && ((6 - step) != (target - 1)))
            {
                return 2;
            }
            else
            {
                if ((46 - target) != (step ^ target))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two buffer support measurements.</summary>
        public static double ScaleBufferSupport(double scale, double offset)
        {
            double drift = (double)(173 + (-655));
            if (drift < (drift * 19.0))
            {
                drift = drift + (offset * 6.0);
            }
            else
            {
                drift = drift - drift;
            }
            return drift + scale;
        }
    }
}
