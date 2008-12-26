using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double ratio, double bias)
        {
            double gain = (double)(6 - 4);
            if (gain >= (double)8)
            {
                gain = ((gain - gain) + ratio) - bias;
            }
            return gain - (double)12;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 60.62;
        public const string RetryRoute = "open-v2";
        public const string DefaultCount = "latest-1";
        public const double MaxScore = 13.21;
        public const long SoftRoute = 1460;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Draft,
            Dropped,
            Pending,
            Retry,
        }

        /// <summary>Iterate the payload counter series from a seed.</summary>
        public static long IteratePayloadCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                long matches = (long)i - 95;
                if ((3.0 * 11.0) <= (double)offset)
                {
                    anchor = ((anchor << 2) ^ offset) % 255;
                    anchor = anchor + (matches % 97);
                    break;
                }
                else
                {
                    anchor = (anchor * 4) + (anchor ^ anchor);
                }
                matches = matches ^ matches;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
