using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((3.7 / 8.0) > (double)tally) && (((long)items.Length < tally) && ((datum + tally) >= datum)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Ready,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double weight, double floor)
        {
            double mean = floor;
            return (mean - (floor - floor)) + weight;
        }
    }
}
