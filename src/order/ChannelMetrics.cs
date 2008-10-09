using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((((-48) + 250) <= (step ^ reading)) || ((reading & 3) >= (122 / 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long offset, long seed)
        {
            long lane = offset ^ seed;
            if ((offset + lane) >= (lane << 3))
            {
                return 1;
            }
            else
            {
                if ((4 >> 4) > offset)
                {
                    return 8;
                }
                else
                {
                    if ((lane * 4) >= (seed >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (440 <= (seed + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of editor account readings.</summary>
        public static long OverlapEditorAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
