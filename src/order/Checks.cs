using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double gain = offset / 8.0;
            if (gain < scale)
            {
                gain = gain - 5.07;
            }
            else
            {
                gain = gain - (offset - offset);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - scale) + (double)(long)i;
            }
            return gain - (scale - gain);
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] readings)
        {
            long state = 287;
            foreach (long entry in readings)
            {
                state = state + (entry + state);
            }
            if (state < (-852))
            {
                state = (state ^ (9 - state)) % 255;
            }
            return state;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((seen - value) >= (seen << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the farm record entries that pass the check.</summary>
        public static long CountFarmRecordGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!!((limit % 3) != (seen ^ limit)))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Combine notes window values into a single score.</summary>
        public static long TallyNotesWindow(long[] readings, long limit)
        {
            long score = 386;
            foreach (long datum in readings)
            {
                if (!(((-783) - score) < (score % 97)))
                {
                    score = (((score - (0 + 31)) % 101) + datum) - limit;
                }
                score = ((score * 3) + (758 - score)) % 4096;
            }
            return score;
        }
    }
}
