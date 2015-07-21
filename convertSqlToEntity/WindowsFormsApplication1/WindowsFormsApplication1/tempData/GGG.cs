using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ff
{
    [Serializable]
    public class GGG
    {
          //申报单位id
          private long agency_id;
          //分配调入生效金额
          private decimal assign_add_amount;
          //分配在途调入
          private decimal assign_add_amounting;
          //分配调出生效金额
          private decimal assign_sub_amount;
          //分配调出在途金额
          private decimal assign_sub_amounting;
          //额度ID主键
          private long balance_id;
          //额度类型ID
          private long balance_type_id;
          //指标来源id
          private long bgt_source_id;
          //财力加存储列，（已生效）
          private decimal budget_add_amount;
          //财力在途追加存储列
          private decimal budget_add_amounting;
          //年初预算金额
          private decimal budget_amount;
          //财力收回存储列，已生效
          private decimal budget_sub_amount;
          //财力在途收回存储列
          private decimal budget_sub_amounting;
          private string c_field1;
          private string c_field2;
          private string c_field3;
          private string c_field4;
          private string c_field5;
          //创建时间
          private DateTime create_date;
          //创建用户
          private long create_user;
          private long ele_hold1_id;
          private long ele_hold10_id;
          private long ele_hold2_id;
          private long ele_hold3_id;
          private long ele_hold4_id;
          private long ele_hold5_id;
          private long ele_hold6_id;
          private long ele_hold7_id;
          private long ele_hold8_id;
          private long ele_hold9_id;
          //额度汇总串，用于标识唯一一条额度
          private string ele_str;
          //经济科目ID
          private long exp_eco_id;
          //功能科目ID
          private long exp_func_id;
          //筹资类型
          private long financing_type_id;
          //项目主管科室
          private long in_mof_dep_id;
          //执行单位id
          private long in_ps_agency_id;
          //政府投资安排资金金额
          private decimal inv_pay_amount;
          //是否
          private long is_assign;
          //版本号
          private long last_ver;
          //调剂入生效金额
          private decimal modulate_add_amount;
          //调剂入在途金额
          private decimal modulate_add_amounting;
          //调剂出金额生效金额
          private decimal modulate_sub_amount;
          //调剂出金额在途金额
          private decimal modulate_sub_amounting;
          //业务处室id
          private long mof_dep_id;
          private long n_field1;
          private long n_field2;
          private long n_field3;
          private long n_field4;
          private long n_field5;
          //支付金额
          private decimal pay_amount;
          //是否转移支付补助下级
          private long pay_flag;
          private string pfs_detail_content;
          //预算性质id
          private long prj_budget_kind_id;
          //预算类型id
          private long prj_budget_type_id;
          //项目编码
          private string prj_code;
          //标准项目ID
          private long prj_std_id;
          //资金ID主键
          private long ps_pfs_id;
          //采购品目
          private long puritem_id;
          //转指标金额
          private decimal quota_amount;
          //转指标收回金额
          private decimal quota_back_amount;
          //转指标级次ID
          private long quota_level_id;
          //权限
          private long rcid;
          //1政府采购，0非政府采购
          private long stock_flag;
          //政府采购计划金额
          private decimal stock_plan_amount;
          //是否预留
          private long surplus_flag;
          //预算年度
          private long year;

          public long Agency_id
          {
          	get { return agency_id; }
          	set { agency_id = value; }
          }
          public decimal Assign_add_amount
          {
          	get { return assign_add_amount; }
          	set { assign_add_amount = value; }
          }
          public decimal Assign_add_amounting
          {
          	get { return assign_add_amounting; }
          	set { assign_add_amounting = value; }
          }
          public decimal Assign_sub_amount
          {
          	get { return assign_sub_amount; }
          	set { assign_sub_amount = value; }
          }
          public decimal Assign_sub_amounting
          {
          	get { return assign_sub_amounting; }
          	set { assign_sub_amounting = value; }
          }
          public long Balance_id
          {
          	get { return balance_id; }
          	set { balance_id = value; }
          }
          public long Balance_type_id
          {
          	get { return balance_type_id; }
          	set { balance_type_id = value; }
          }
          public long Bgt_source_id
          {
          	get { return bgt_source_id; }
          	set { bgt_source_id = value; }
          }
          public decimal Budget_add_amount
          {
          	get { return budget_add_amount; }
          	set { budget_add_amount = value; }
          }
          public decimal Budget_add_amounting
          {
          	get { return budget_add_amounting; }
          	set { budget_add_amounting = value; }
          }
          public decimal Budget_amount
          {
          	get { return budget_amount; }
          	set { budget_amount = value; }
          }
          public decimal Budget_sub_amount
          {
          	get { return budget_sub_amount; }
          	set { budget_sub_amount = value; }
          }
          public decimal Budget_sub_amounting
          {
          	get { return budget_sub_amounting; }
          	set { budget_sub_amounting = value; }
          }
          public string C_field1
          {
          	get { return c_field1; }
          	set { c_field1 = value; }
          }
          public string C_field2
          {
          	get { return c_field2; }
          	set { c_field2 = value; }
          }
          public string C_field3
          {
          	get { return c_field3; }
          	set { c_field3 = value; }
          }
          public string C_field4
          {
          	get { return c_field4; }
          	set { c_field4 = value; }
          }
          public string C_field5
          {
          	get { return c_field5; }
          	set { c_field5 = value; }
          }
          public DateTime Create_date
          {
          	get { return create_date; }
          	set { create_date = value; }
          }
          public long Create_user
          {
          	get { return create_user; }
          	set { create_user = value; }
          }
          public long Ele_hold1_id
          {
          	get { return ele_hold1_id; }
          	set { ele_hold1_id = value; }
          }
          public long Ele_hold10_id
          {
          	get { return ele_hold10_id; }
          	set { ele_hold10_id = value; }
          }
          public long Ele_hold2_id
          {
          	get { return ele_hold2_id; }
          	set { ele_hold2_id = value; }
          }
          public long Ele_hold3_id
          {
          	get { return ele_hold3_id; }
          	set { ele_hold3_id = value; }
          }
          public long Ele_hold4_id
          {
          	get { return ele_hold4_id; }
          	set { ele_hold4_id = value; }
          }
          public long Ele_hold5_id
          {
          	get { return ele_hold5_id; }
          	set { ele_hold5_id = value; }
          }
          public long Ele_hold6_id
          {
          	get { return ele_hold6_id; }
          	set { ele_hold6_id = value; }
          }
          public long Ele_hold7_id
          {
          	get { return ele_hold7_id; }
          	set { ele_hold7_id = value; }
          }
          public long Ele_hold8_id
          {
          	get { return ele_hold8_id; }
          	set { ele_hold8_id = value; }
          }
          public long Ele_hold9_id
          {
          	get { return ele_hold9_id; }
          	set { ele_hold9_id = value; }
          }
          public string Ele_str
          {
          	get { return ele_str; }
          	set { ele_str = value; }
          }
          public long Exp_eco_id
          {
          	get { return exp_eco_id; }
          	set { exp_eco_id = value; }
          }
          public long Exp_func_id
          {
          	get { return exp_func_id; }
          	set { exp_func_id = value; }
          }
          public long Financing_type_id
          {
          	get { return financing_type_id; }
          	set { financing_type_id = value; }
          }
          public long In_mof_dep_id
          {
          	get { return in_mof_dep_id; }
          	set { in_mof_dep_id = value; }
          }
          public long In_ps_agency_id
          {
          	get { return in_ps_agency_id; }
          	set { in_ps_agency_id = value; }
          }
          public decimal Inv_pay_amount
          {
          	get { return inv_pay_amount; }
          	set { inv_pay_amount = value; }
          }
          public long Is_assign
          {
          	get { return is_assign; }
          	set { is_assign = value; }
          }
          public long Last_ver
          {
          	get { return last_ver; }
          	set { last_ver = value; }
          }
          public decimal Modulate_add_amount
          {
          	get { return modulate_add_amount; }
          	set { modulate_add_amount = value; }
          }
          public decimal Modulate_add_amounting
          {
          	get { return modulate_add_amounting; }
          	set { modulate_add_amounting = value; }
          }
          public decimal Modulate_sub_amount
          {
          	get { return modulate_sub_amount; }
          	set { modulate_sub_amount = value; }
          }
          public decimal Modulate_sub_amounting
          {
          	get { return modulate_sub_amounting; }
          	set { modulate_sub_amounting = value; }
          }
          public long Mof_dep_id
          {
          	get { return mof_dep_id; }
          	set { mof_dep_id = value; }
          }
          public long N_field1
          {
          	get { return n_field1; }
          	set { n_field1 = value; }
          }
          public long N_field2
          {
          	get { return n_field2; }
          	set { n_field2 = value; }
          }
          public long N_field3
          {
          	get { return n_field3; }
          	set { n_field3 = value; }
          }
          public long N_field4
          {
          	get { return n_field4; }
          	set { n_field4 = value; }
          }
          public long N_field5
          {
          	get { return n_field5; }
          	set { n_field5 = value; }
          }
          public decimal Pay_amount
          {
          	get { return pay_amount; }
          	set { pay_amount = value; }
          }
          public long Pay_flag
          {
          	get { return pay_flag; }
          	set { pay_flag = value; }
          }
          public string Pfs_detail_content
          {
          	get { return pfs_detail_content; }
          	set { pfs_detail_content = value; }
          }
          public long Prj_budget_kind_id
          {
          	get { return prj_budget_kind_id; }
          	set { prj_budget_kind_id = value; }
          }
          public long Prj_budget_type_id
          {
          	get { return prj_budget_type_id; }
          	set { prj_budget_type_id = value; }
          }
          public string Prj_code
          {
          	get { return prj_code; }
          	set { prj_code = value; }
          }
          public long Prj_std_id
          {
          	get { return prj_std_id; }
          	set { prj_std_id = value; }
          }
          public long Ps_pfs_id
          {
          	get { return ps_pfs_id; }
          	set { ps_pfs_id = value; }
          }
          public long Puritem_id
          {
          	get { return puritem_id; }
          	set { puritem_id = value; }
          }
          public decimal Quota_amount
          {
          	get { return quota_amount; }
          	set { quota_amount = value; }
          }
          public decimal Quota_back_amount
          {
          	get { return quota_back_amount; }
          	set { quota_back_amount = value; }
          }
          public long Quota_level_id
          {
          	get { return quota_level_id; }
          	set { quota_level_id = value; }
          }
          public long Rcid
          {
          	get { return rcid; }
          	set { rcid = value; }
          }
          public long Stock_flag
          {
          	get { return stock_flag; }
          	set { stock_flag = value; }
          }
          public decimal Stock_plan_amount
          {
          	get { return stock_plan_amount; }
          	set { stock_plan_amount = value; }
          }
          public long Surplus_flag
          {
          	get { return surplus_flag; }
          	set { surplus_flag = value; }
          }
          public long Year
          {
          	get { return year; }
          	set { year = value; }
          }

	}
}

