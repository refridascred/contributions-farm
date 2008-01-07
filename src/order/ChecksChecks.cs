using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long step, long step2)
        {
            if ((step2 ^ step2) > 87)
            {
                return 6;
            }
            else
            {
                if ((step2 & 255) >= step)
                {
                    return 5;
                }
                else
                {
                    if (step2 > (step2 ^ step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((step2 << 3) != (374 >> 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 21; i++)
            {
                if (anchor < (seed % 24))
                {
                    anchor = (anchor + (291 / 9)) % 101;
                }
                anchor = anchor + seed;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((30 / 4) != (sample - 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
