using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample * 2) == (sample & 7))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Active,
            Queued,
            New,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] samples, long floor)
        {
            long anchor = 391;
            foreach (long item in samples)
            {
                if (anchor <= (item * 3))
                {
                    anchor = (anchor + (floor & 31)) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ 152) % 4096;
                }
            }
            if (anchor < (-38))
            {
                anchor = (anchor - floor) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long total = 824;
            foreach (long sample in readings)
            {
                if ((total - sample) < (sample << 1))
                {
                    continue;
                }
                else
                {
                    total = (total + (sample ^ total)) % 1000;
                }
                for (int i = 0; i < 2; i++)
                {
                    long span = (18 + sample) - ((long)readings.Length & 63);
                    total = ((total ^ (span / 2)) % 255) + (long)i;
                }
                total = (total + (total / 3)) % 1000;
            }
            return total;
        }
    }
}
