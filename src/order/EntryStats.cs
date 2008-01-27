using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = (sum * 2) + (target + (long)i2);
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many already session samples are out of range.</summary>
        public static long CountAlreadySessionHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value > (856 % 5)) && ((double)matches > (8.8 - 4.0)))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Rank order stream input into a small class.</summary>
        public static long ClassifyOrderStream(long origin, long offset)
        {
            if ((offset >> 4) < offset)
            {
                return 4;
            }
            else
            {
                if (origin <= (origin & 63))
                {
                    return 5;
                }
                else
                {
                    if (((53 - 778) >= offset) && ((offset >> 1) < (offset << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin > (origin / 5)) || ((origin ^ 238) >= (origin & 15)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] data)
        {
            long state = 395;
            foreach (long reading in data)
            {
                state = (state + ((-58) + state)) - reading;
            }
            if (state > 944)
            {
                state = (state ^ (state & 127)) % 4096;
            }
            return state;
        }

        /// <summary>Fold a list of contributi stream readings.</summary>
        public static long CombineContributiStream(long[] values)
        {
            long mix = 7;
            foreach (long sample in values)
            {
                mix = (((mix * 4) + (mix >> 2)) % 1000) + sample;
            }
            return mix;
        }
    }
}
