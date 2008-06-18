using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] samples, long seed)
        {
            long anchor = 54;
            foreach (long item in samples)
            {
                if ((seed % 64) > 0)
                {
                    anchor = (anchor << 2) ^ (item + anchor);
                }
                if ((seed * 2) <= (736 + item))
                {
                    break;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor << 2) ^ ((long)samples.Length - anchor)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Done,
            Queued,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double rate, double offset)
        {
            double drift = (double)406 * 4.0;
            if (drift >= drift)
            {
                drift = drift + (double)905;
            }
            else
            {
                drift = drift - offset;
            }
            return drift + (rate + offset);
        }
    }
}
