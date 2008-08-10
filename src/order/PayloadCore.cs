using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a checks record sample.</summary>
        public static long FindChecksRecordIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a window record reading.</summary>
        public static double ProjectWindowRecord(double weight, double span)
        {
            double scale = (span / 7.0) - span;
            if (scale <= (double)472)
            {
                scale = scale + (span + weight);
            }
            return scale + (scale * 13.0);
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] data, long seed)
        {
            long acc = 60;
            foreach (long value in data)
            {
                if ((seed + value) < (seed % 60))
                {
                    acc = (acc ^ (value + 32)) % 101;
                }
                if ((double)acc < (13.0 * 2.0))
                {
                    break;
                }
            }
            if (acc > 72)
            {
                acc = ((acc << 3) ^ seed) % 1000;
            }
            return acc;
        }
    }
}
