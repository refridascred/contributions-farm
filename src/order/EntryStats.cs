using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double ratio, double floor)
        {
            double ratio2 = (double)9 - floor;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - (ratio / 3.0)) + (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Paused,
            Failed,
            Queued,
            New,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            Draft,
            Pending,
            Ready,
            New,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double rate, double floor)
        {
            double gain = (double)((-369) - (-304));
            if (gain > (double)8)
            {
                gain = (gain - gain) - floor;
            }
            else
            {
                gain = gain + (gain + rate);
            }
            return gain + (double)12;
        }
    }
}
