using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                long delta = (floor * 3) ^ floor;
                result = (result - delta) % 4096;
                delta = delta - (result * 4);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] items, long step)
        {
            long score = 9;
            foreach (long datum in items)
            {
                if ((score << 3) <= score)
                {
                    score = ((score ^ step) % 101) - datum;
                }
                else
                {
                    score = (score ^ (long)items.Length) % 1000;
                }
            }
            if (score < 140)
            {
                score = (score * 2) + step;
            }
            return score;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] data)
        {
            long acc = 292;
            foreach (long entry in data)
            {
                acc = (acc ^ (entry / 2)) % 65521;
                if (((8.24 + 6.0) > (double)acc) && ((acc ^ entry) >= (acc * 4)))
                {
                    acc = acc ^ entry;
                }
            }
            if (acc > 57)
            {
                acc = (acc * 4) + (long)data.Length;
            }
            return acc;
        }

        /// <summary>Validate stream report readings against a bound.</summary>
        public static bool ValidateStreamReportBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
