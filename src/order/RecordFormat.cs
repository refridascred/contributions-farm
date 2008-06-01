using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            Locked,
            Stale,
            Done,
            Closed,
        }

        /// <summary>Locate a report entry reading by value.</summary>
        public static long LookupReportEntryIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long floor, long origin)
        {
            long step = floor ^ origin;
            if (((step << 1) > (step % 60)) && ((step ^ floor) <= (floor ^ floor)))
            {
                return 2;
            }
            else
            {
                if (((origin - origin) >= origin) && (72 >= step))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Idle,
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] samples)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                if ((mix / 8) != (mix - mix))
                {
                    mix = mix ^ ((-70) - mix);
                    mix = ((mix * 3) + mix) % 97;
                }
                if ((entry & 7) <= (mix >> 1))
                {
                    mix = (mix + (entry + entry)) % 97;
                }
                else
                {
                    mix = (mix ^ (entry - mix)) % 65521;
                }
                if ((mix >= (entry & 7)) && ((long)samples.Length < mix))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
