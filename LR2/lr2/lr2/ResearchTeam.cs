using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lr2
{
    public enum TimeFrame
    {
        Year,
        TwoYears,
        Long
    }
    internal class ResearchTeam
    {
        string _theme;
        string _orgName;
        int _regNuber;
        TimeFrame _researchTime;
        Paper[] _papersList;

        public ResearchTeam(string theme, string orgname, int regnumber, TimeFrame researchtime, Paper[] paperslist)
        {
            _theme = theme;
            _orgName = orgname;
            _regNuber = regnumber;
            _researchTime = researchtime;
            _papersList = paperslist;
        }

        public ResearchTeam() : this("theme", "orgname", 0, 0, null)
        {

        }
        // СВОЙСТВА
        public string Theme
        {
            get 
            { 
                return _theme;
            }
            set
            {
                _theme = value;
            }
        }

        public string OrgName
        {
            get 
            {
                return _orgName;
            }
            set
            {
                _orgName = value;
            }
        }

        public int RegNuber
        {
            get 
            { 
                return _regNuber; 
            }
            set
            {
                _regNuber=value;
            }
        }

        public TimeFrame ResearchTime
        {
            get 
            {
                return _researchTime;
            }
            set 
            {
                _researchTime=value; 
            }
        }

        public Paper[] PaperList
        {
            get { return _papersList;}
        }

        //свойство типа Paper(только с методом get), которое возвращает ссылку на публикацию с самой
        //поздней датой выхода; если список публикаций пустой, свойство возвращает значение null;
        public Paper LastPaper
        {
            get
            {
                if(PaperList == null|| PaperList.Length==0)
                {
                    return null;
                }
                else
                {
                    DateTime max = DateTime.MinValue;
                    int maxIndex = 0;
                    for (int i = 0; i < PaperList.Length; i++)
                    {
                        if(PaperList[i].pubdate > max)
                        {
                            max = PaperList[i].pubdate;
                            maxIndex = i;   
                        }
                    }
                        return PaperList[maxIndex];
                }
            }

        }
        //
        public void AddPapers(params Paper[] newPapers)
        {
          
        }

        public string ToFullString()
        {
            return ($"Theme: {_theme}, OrgName: {_orgName}, RegNumber: {_regNuber}, ResearchTime: {_researchTime}, PapersList {_papersList}");
        }

        public string ToShortString()
        {
            return ($"Theme: {_theme}, OrgName: {_orgName}, RegNumber: {_regNuber}, ResearchTime: {_researchTime}");
        }
    }
}
