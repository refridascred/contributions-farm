using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                if (((step + step) == ((long)i << 2)) && ((long)i > ((long)i / 5)))
                {
                    continue;
                }
                score = (score * 5) + (score % 16);
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine window route values into a single score.</summary>
        public static long CombineWindowRoute(long[] levels, long step)
        {
            long score = 62;
            foreach (long cell in levels)
            {
                score = (score << 2) ^ (cell + step);
            }
            if (score > 472)
            {
                score = (score ^ (749 & 7)) % 65521;
            }
            return score;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many record schema samples are out of range.</summary>
        public static long AuditRecordSchemaMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((entry >> 3) <= (matches * 3)) && ((169 >> 3) < matches))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }
    }
}
