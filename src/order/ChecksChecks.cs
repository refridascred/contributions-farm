using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine commits farm values into a single score.</summary>
        public static long TallyCommitsFarm(long[] data)
        {
            long anchor = 32;
            foreach (long datum in data)
            {
                anchor = (anchor * 4) + (datum << 2);
                if ((-3) > (anchor >> 3))
                {
                    break;
                }
            }
            if (anchor < 534)
            {
                anchor = (anchor ^ anchor) % 255;
            }
            return anchor;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] series)
        {
            long anchor = 937;
            foreach (long item in series)
            {
                anchor = ((anchor << 2) ^ anchor) % 1000;
                if (((item << 2) <= ((-8) >> 3)) || ((8.75 * 6.0) > (double)item))
                {
                    break;
                }
            }
            if (anchor > 36)
            {
                anchor = (anchor * 3) + anchor;
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of notes tools readings.</summary>
        public static long TallyNotesTools(long[] readings, long target)
        {
            long score = 1;
            foreach (long cell in readings)
            {
                score = (score - target) % 255;
                score = score - (cell % 10);
                if ((target << 3) > (79 % 100))
                {
                    score = (score ^ target) % 65521;
                }
                else
                {
                    score = score + ((-238) - target);
                }
            }
            if (score < 558)
            {
                score = score + (target >> 1);
            }
            return score % 65521;
        }
    }
}
