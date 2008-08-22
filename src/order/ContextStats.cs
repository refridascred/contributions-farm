using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((6.0 * 2.3) < (double)reading)
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Paused,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double rate, double offset)
        {
            double load = offset;
            if (load > (double)115)
            {
                load = load - offset;
            }
            return load + (1.0 + rate);
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Ready,
            Done,
            Queued,
            New,
        }
    }
}
