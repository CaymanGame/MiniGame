using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace Tools
{
     //using Assets.EventSystem;
     ///<summary>
     ///@ version 1.0 /2017.0216/ :用于读表专用,科目任务列表，机器按键列表
     ///@ author gong
     ///@ version 1.1 /2017.0228/ :修改了表的加载方式，fn_loadtable（）方法可以处理所以机器的表格和章节的表格
     ///@ author gong
     ///@ version 1.2 /2017.0307/ :获取章节的所有步骤：fn_getMachineData()
     ///@ author gong
     ///@ version 1.3 /2017.0421/ :加入汽车表的读取
     ///@ author gong
     ///</summary>
     public class S_LoadTable : GenericDontDestroy<S_LoadTable>
     {
          

          //	void Start(){
          //	
          //	}
          /// <summary>
          /// 根据表的名称加载表
          /// </summary>
          /// <param name="_tablename">Tablename.</param>
          public void fn_loadtable(string _tablename)
          {
               switch (_tablename)
               {
                    
                    //case "table_names"://读取第一张表单           
                    //     CSVManager.fnReadTextToDic(_tablename, m_alltables);
                    //     break;
                    //case "sound_names"://读取声音表单           
                    //     CSVManager.fnReadTextToDic(_tablename, m_allsounds);
                    //     break;
                    //case "special_sound_ce"://读取特殊声音的表单        
                    //     CSVManager.fnReadTextToDic(_tablename, m_specialsounds);
                    //     break;
                    //case "normal_sound"://步骤开始结束的语音提示    
                    //     CSVManager.fnReadTextToDic(_tablename, m_normalsound);
                    //     break;
                    //case "CDP_groupname"://cdp 组名称    
                    //     CSVManager.fnReadTextToDic(_tablename, m_groupname);
                    //     break;
                    //case "CDP_item"://cdp 的成员项
                    //     CSVManager.fnReadTextToDic(_tablename, m_cdpItem);
                    //     Invoke("fnp_rePackdate", 1.5f);
                    //     break;
                    //case "introduce_table"://机器介绍的文字和配置表
                    //     CSVManager.fnReadTextToDic(_tablename, m_introduce);
                    //     Invoke("fnp_reLoadIntroduceTable", 1.5f);
                    //     break;
                    //case "LoginUI":
                    //     CSVManager.fnReadTextToDic(_tablename, m_loginui_dic);
                    //     break;
                    default:
                         break;
               }
          }
        
          /// <summary>
          /// 读取机器和章节步骤的表格
          /// </summary>
          /// <param name="_tablename">表名称</param>
          /// <param name="_type">表的类型</param>
          public void fn_loadtable(string _tablename, string _type)
          {
               switch (_type)
               {
                  
                    //case "ui"://UI的表格
                    //     if (!m_UIDate.ContainsKey(_tablename))
                    //     {
                    //          m_UIDate.Add(_tablename, new Dictionary<string, UILanguageTable>());
                    //          CSVManager.fnReadTextToDic(_tablename, m_UIDate[_tablename]);
                    //          m_tableNames.Add(_tablename);
                    //     }
                    //     break;
                    //case "name":
                    //     if (!m_nameinfo.ContainsKey(_tablename))
                    //     {
                    //          m_nameinfo.Add(_tablename, new Dictionary<string, NameItemInfo>());
                    //          CSVManager.fnReadTextToDic(_tablename, m_nameinfo[_tablename]);
                    //          m_tableNames.Add(_tablename);
                    //     }
                    //     break;
                    //case "init":
                    //     if (!m_subject_init.ContainsKey(_tablename))
                    //     {
                    //          m_tableNames.Add(_tablename);
                    //          m_subject_init.Add(_tablename, new Dictionary<string, subject_init>());
                    //          CSVManager.fnReadTextToDic(_tablename, m_subject_init[_tablename]);
                    //     }
                    //     break;
                    //case "step":
                    //     if (!m_subject_step.ContainsKey(_tablename))
                    //     {
                    //          m_tableNames.Add(_tablename);
                    //          m_subject_step.Add(_tablename, new Dictionary<string, subject_step>());
                    //          CSVManager.fnReadTextToDic(_tablename, m_subject_step[_tablename]);
                    //     }
                    //     break;
                    //case "item":
                    //     if (!m_item_name.ContainsKey(_tablename))
                    //     {
                    //          m_tableNames.Add(_tablename);
                    //          m_item_name.Add(_tablename, new Dictionary<string, item_name>());
                    //          CSVManager.fnReadTextToDic(_tablename, m_item_name[_tablename]);
                    //     }
                    //     break;
                    default:
                         break;
               }

          }

         
        
       
         

     }

}