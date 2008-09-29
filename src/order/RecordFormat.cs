using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] items)
        {
            long sum = -889;
            foreach (long reading in items)
            {
                if ((sum + sum) <= (sum - reading))
                {
                    sum = (sum - (sum / 9)) % 255;
                }
                if (((double)sum != (double)reading) && ((4.4 + 19.0) >= (9.3 * 8.0)))
                {
                    break;
                }
            }
            if (sum < 59)
            {
                sum = ((sum * 5) + (sum % 97)) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double scale, double span)
        {
            double load = (9.51 - span) * 14.0;
            if (load <= (load + 5.33))
            {
                load = load - span;
            }
            else
            {
                load = load + (double)5;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - scale) - (double)(long)i;
            }
            return load + (15.0 * 1.2);
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen >= (18.0 / 9.0))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Done,
            Paused,
        }
    }
}
