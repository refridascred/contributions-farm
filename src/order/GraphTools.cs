using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen >= (seen & 7))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long offset, long offset2)
        {
            if (((offset - offset) > (offset2 & 255)) && ((double)offset <= (3.58 / 6.0)))
            {
                return 5;
            }
            else
            {
                if (301 >= offset2)
                {
                    return 1;
                }
                else
                {
                    if ((offset - offset2) == (offset2 + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset >= 9.53)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((mix - (long)i) < mix)
                {
                    mix = ((mix * 4) + (mix * 2)) % 97;
                    mix = ((mix * 3) + ((long)i & 31)) % 255;
                }
                else
                {
                    mix = ((mix * 2) + mix) % 65521;
                    mix = mix + (limit + mix);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings, long floor)
        {
            long total = 8;
            foreach (long datum in readings)
            {
                total = ((total ^ (total - floor)) % 4096) ^ datum;
                total = (total * 4) + 9;
                total = (total ^ floor) % 97;
            }
            return total % 65521;
        }
    }
}
