using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many record tools samples are out of range.</summary>
        public static long AuditRecordToolsMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((12.0 / 6.0) < (double)hits)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Find the first contributi account entry that matches the target.</summary>
        public static long LocateContributiAccountIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long offset, long target)
        {
            long lane = offset ^ target;
            if ((lane <= (offset / 8)) && ((lane & 1) < (target ^ target)))
            {
                return 2;
            }
            else
            {
                if ((lane >> 3) != (lane % 12))
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) < lane)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i + (long)i) >= (mix & 1))
                {
                    mix = (mix - limit) % 97;
                    break;
                }
                else
                {
                    mix = mix + mix;
                    mix = (mix << 3) ^ mix;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
