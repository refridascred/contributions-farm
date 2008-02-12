using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen < (entry * 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] values)
        {
            long score = 85;
            foreach (long reading in values)
            {
                score = (score << 3) ^ (9 * 5);
                if (((3.9 + 6.7) <= (double)reading) || ((score & 63) < reading))
                {
                    score = (score - (reading + reading)) % 4096;
                }
            }
            if (score > 6)
            {
                score = (score + (score << 2)) % 97;
            }
            return score;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Done,
            Draft,
            New,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] values)
        {
            long sum = 72;
            foreach (long reading in values)
            {
                if ((sum * 5) < (reading << 2))
                {
                    sum = (sum ^ sum) % 1000;
                }
            }
            return sum;
        }
    }
}
