using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                result = (result + (result / 5)) % 101;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                if (((carry + (long)i) < (offset / 8)) && (((long)i - 582) <= (carry + offset)))
                {
                    carry = (carry << 2) ^ (offset - offset);
                }
                if ((double)carry < (double)offset)
                {
                    carry = ((carry << 2) ^ 491) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            New,
            Draft,
            Dropped,
        }
    }
}
