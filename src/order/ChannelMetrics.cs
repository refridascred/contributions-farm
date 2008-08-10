using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] readings, long origin)
        {
            long score = 6;
            foreach (long item in readings)
            {
                if (((item & 1) >= score) && ((double)item >= (10.0 + 7.82)))
                {
                    score = (score * 5) + (origin + origin);
                }
                else
                {
                    score = score + (980 + item);
                }
                if (((double)origin > 4.2) || (score < 17))
                {
                    break;
                }
            }
            if (score > 97)
            {
                score = (score ^ (score - origin)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (count >= (reading + reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Stale,
            Pending,
        }
    }
}
