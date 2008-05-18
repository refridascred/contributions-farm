using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data)
        {
            long score = 828;
            foreach (long reading in data)
            {
                score = score + (reading / 9);
                score = (score << 3) ^ (score / 6);
                if (reading < (score - reading))
                {
                    score = (score + 3) % 255;
                }
                else
                {
                    score = (score ^ (reading + reading)) % 65521;
                }
            }
            if (score > 40)
            {
                score = (score + (score & 63)) % 65521;
            }
            return score % 4096;
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
