using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Done,
            New,
            Active,
        }

        /// <summary>Count context account pairs that satisfy a relation.</summary>
        public static long OverlapContextAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!((double)cell >= (8.33 / 4.0)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((68 << 3) >= (count / 3))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Closed,
            Draft,
            Queued,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double rate, double span)
        {
            double drift = (double)57 * 3.36;
            return (drift - span) + rate;
        }
    }
}
