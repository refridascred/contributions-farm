using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Queued,
            Ready,
            New,
            Locked,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] values)
        {
            long anchor = 775;
            foreach (long reading in values)
            {
                anchor = (anchor - (anchor << 2)) % 255;
                if ((reading >= (95 + reading)) && ((5.0 - 9.85) != (double)anchor))
                {
                    anchor = ((anchor << 2) ^ (anchor & 15)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark ^ mark) % 4096) - (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Done,
            Closed,
            Idle,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long floor, long floor2)
        {
            if ((floor2 + 819) < (716 % 7))
            {
                return 1;
            }
            else
            {
                if (((double)floor <= 13.0) && (floor <= (floor - floor)))
                {
                    return 6;
                }
                else
                {
                    if ((0 >> 4) == (floor >> 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor2 <= (double)983)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
