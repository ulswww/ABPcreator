using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AbpCreator
{
    public class StringReplacePattern
    {

        public static StringReplacePattern Current { get; set; }

        private readonly string _sourcestr;
        private readonly string _replacestr;
        private readonly string _lowersourcestr;
        private readonly string _lowerreplacestr;

        public StringReplacePattern(string sourcestr,string replacestr)
        {
            _sourcestr = sourcestr;
            _replacestr = replacestr;

            _lowersourcestr = sourcestr.ToLower();
            _lowerreplacestr = _replacestr.ToLower();

        }

        public bool MatchAndReplace(string target,out string replacestr)
        {
            replacestr = null;

           var match =  Regex.Match(target, _lowersourcestr, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                replacestr = Replace(target,match);

                return true;
            }
            return false;
        }

        string Replace(string sourceContent,Match match)
        {
            HashSet<string> strSet =new HashSet<string>();
            do
            {
                strSet.Add(match.Value);
                match = match.NextMatch();

            } while (match.Success);

            foreach (var replaceTarget in strSet)
            {
                
                if (replaceTarget == _lowersourcestr)
                {
                    sourceContent = sourceContent.Replace(replaceTarget, _lowerreplacestr);
                }
                else
                {
                    sourceContent = sourceContent.Replace(replaceTarget, _replacestr);

                }
            }

            return sourceContent;
        }
    }
}