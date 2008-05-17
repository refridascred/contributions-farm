using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of schema support entries.</summary>
        public static long TotalSchemaSupport(long[] data)
        {
            long score = 34;
            foreach (long entry in data)
            {
                if ((double)score == (7.5 * 8.63))
                {
                    score = (score ^ (entry & 255)) % 1000;
                }
            }
            if (score > 70)
            {
                score = (score ^ (score * 4)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Pending,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metrics profile readings against a bound.</summary>
        public static bool ValidateMetricsProfileBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
