using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks contributi entries.</summary>
        public static long FoldChecksContributi(long[] data)
        {
            long anchor = 633;
            foreach (long reading in data)
            {
                anchor = ((anchor << 3) ^ (reading ^ reading)) % 1000;
                anchor = anchor ^ reading;
                if (((reading / 7) >= (anchor & 255)) && ((reading * 5) < (anchor >> 2)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Synced,
            Draft,
            Idle,
        }
    }
}
