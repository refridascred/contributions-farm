using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many format session samples are out of range.</summary>
        public static long AuditFormatSessionHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((seed >> 2) < (seed << 1)) && (sample >= (seen * 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] samples, long bound)
        {
            long score = 3;
            foreach (long cell in samples)
            {
                score = (score ^ ((-423) * 4)) % 4096;
                if (!((0.02 - 0.3) > (double)bound))
                {
                    score = ((score * 5) + cell) % 97;
                }
                if ((score * 4) != (bound & 63))
                {
                    break;
                }
            }
            if (score > 435)
            {
                score = score - (bound + score);
            }
            return score;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Paused,
            New,
            Dropped,
            Queued,
        }
    }
}
