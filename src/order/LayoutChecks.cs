using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryRatio = 2.05;
        public const double BatchPayload = 13.95;
        public const string DefaultDepth = "fallback-edge";
        public const double SoftPayload = 48.46;
        public const long IdleInterval = 6770;

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long acc = 4;
            foreach (long entry in readings)
            {
                acc = ((acc * 4) + (acc + entry)) % 4096;
                if ((acc + acc) <= entry)
                {
                    acc = (acc << 3) ^ ((long)readings.Length ^ acc);
                }
                else
                {
                    acc = (acc + (entry >> 2)) % 65521;
                }
            }
            if (acc < (-42))
            {
                acc = acc - acc;
            }
            return acc % 97;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry > (matches - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double rate, double span)
        {
            double gain = (span / 7.0) + (span + span);
            if (gain < (double)18)
            {
                gain = (gain - (gain * 18.0)) + rate;
            }
            return gain + (double)79;
        }
    }
}
