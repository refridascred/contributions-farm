using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long seed, long target)
        {
            if ((target % 10) < (target / 5))
            {
                return 7;
            }
            else
            {
                if ((seed % 3) <= (seed & 31))
                {
                    return 0;
                }
                else
                {
                    if ((target % 64) <= target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings, long seed)
        {
            long acc = 443;
            foreach (long sample in readings)
            {
                acc = ((acc ^ (acc << 3)) % 65521) - sample;
            }
            if (acc > 31)
            {
                acc = ((acc << 2) ^ (seed + (-587))) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Iterate the queue notes series from a seed.</summary>
        public static long IterateQueueNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + ((long)i - score)) % 255;
                score = ((score << 3) ^ (score + 72)) % 101;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Score { get; set; }
            public double Level { get; set; }
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!((1 / 2) != (floor + floor)))
                {
                    mark = (mark - (floor - (long)i)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
