package com.kkk;

import java.io.Serializable;
import java.math.BigDecimal;
import java.sql.Timestamp;

public class PFS implements Serializable {
	private static final long serialVersionUID = 1L;
	
          //申报单位id
          private long agency_id;
          //分配调入生效金额
          private BigDecimal assign_add_amount;
          //分配在途调入
          private BigDecimal assign_add_amounting;
          //分配调出生效金额
          private BigDecimal assign_sub_amount;
          //分配调出在途金额
          private BigDecimal assign_sub_amounting;
          //额度ID主键
          private long balance_id;
          //额度类型ID
          private long balance_type_id;
          //指标来源id
          private long bgt_source_id;
          //财力加存储列，（已生效）
          private BigDecimal budget_add_amount;
          //财力在途追加存储列
          private BigDecimal budget_add_amounting;
          //年初预算金额
          private BigDecimal budget_amount;
          //财力收回存储列，已生效
          private BigDecimal budget_sub_amount;
          //财力在途收回存储列
          private BigDecimal budget_sub_amounting;
          private String c_field1;
          private String c_field2;
          private String c_field3;
          private String c_field4;
          private String c_field5;
          //创建时间
          private Timestamp create_date;
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
          private String ele_str;
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
          private BigDecimal inv_pay_amount;
          //是否
          private long is_assign;
          //版本号
          private long last_ver;
          //调剂入生效金额
          private BigDecimal modulate_add_amount;
          //调剂入在途金额
          private BigDecimal modulate_add_amounting;
          //调剂出金额生效金额
          private BigDecimal modulate_sub_amount;
          //调剂出金额在途金额
          private BigDecimal modulate_sub_amounting;
          //业务处室id
          private long mof_dep_id;
          private long n_field1;
          private long n_field2;
          private long n_field3;
          private long n_field4;
          private long n_field5;
          //支付金额
          private BigDecimal pay_amount;
          //是否转移支付补助下级
          private long pay_flag;
          private String pfs_detail_content;
          //预算性质id
          private long prj_budget_kind_id;
          //预算类型id
          private long prj_budget_type_id;
          //项目编码
          private String prj_code;
          //标准项目ID
          private long prj_std_id;
          //资金ID主键
          private long ps_pfs_id;
          //采购品目
          private long puritem_id;
          //转指标金额
          private BigDecimal quota_amount;
          //转指标收回金额
          private BigDecimal quota_back_amount;
          //转指标级次ID
          private long quota_level_id;
          //权限
          private long rcid;
          //1政府采购，0非政府采购
          private long stock_flag;
          //政府采购计划金额
          private BigDecimal stock_plan_amount;
          //是否预留
          private long surplus_flag;
          //预算年度
          private long year;

          public long getAgency_id() {
          	return agency_id;
          }
          public void setAgency_id(long agency_id) {
          	this.agency_id = agency_id;
          }
          public BigDecimal getAssign_add_amount() {
          	return assign_add_amount;
          }
          public void setAssign_add_amount(BigDecimal assign_add_amount) {
          	this.assign_add_amount = assign_add_amount;
          }
          public BigDecimal getAssign_add_amounting() {
          	return assign_add_amounting;
          }
          public void setAssign_add_amounting(BigDecimal assign_add_amounting) {
          	this.assign_add_amounting = assign_add_amounting;
          }
          public BigDecimal getAssign_sub_amount() {
          	return assign_sub_amount;
          }
          public void setAssign_sub_amount(BigDecimal assign_sub_amount) {
          	this.assign_sub_amount = assign_sub_amount;
          }
          public BigDecimal getAssign_sub_amounting() {
          	return assign_sub_amounting;
          }
          public void setAssign_sub_amounting(BigDecimal assign_sub_amounting) {
          	this.assign_sub_amounting = assign_sub_amounting;
          }
          public long getBalance_id() {
          	return balance_id;
          }
          public void setBalance_id(long balance_id) {
          	this.balance_id = balance_id;
          }
          public long getBalance_type_id() {
          	return balance_type_id;
          }
          public void setBalance_type_id(long balance_type_id) {
          	this.balance_type_id = balance_type_id;
          }
          public long getBgt_source_id() {
          	return bgt_source_id;
          }
          public void setBgt_source_id(long bgt_source_id) {
          	this.bgt_source_id = bgt_source_id;
          }
          public BigDecimal getBudget_add_amount() {
          	return budget_add_amount;
          }
          public void setBudget_add_amount(BigDecimal budget_add_amount) {
          	this.budget_add_amount = budget_add_amount;
          }
          public BigDecimal getBudget_add_amounting() {
          	return budget_add_amounting;
          }
          public void setBudget_add_amounting(BigDecimal budget_add_amounting) {
          	this.budget_add_amounting = budget_add_amounting;
          }
          public BigDecimal getBudget_amount() {
          	return budget_amount;
          }
          public void setBudget_amount(BigDecimal budget_amount) {
          	this.budget_amount = budget_amount;
          }
          public BigDecimal getBudget_sub_amount() {
          	return budget_sub_amount;
          }
          public void setBudget_sub_amount(BigDecimal budget_sub_amount) {
          	this.budget_sub_amount = budget_sub_amount;
          }
          public BigDecimal getBudget_sub_amounting() {
          	return budget_sub_amounting;
          }
          public void setBudget_sub_amounting(BigDecimal budget_sub_amounting) {
          	this.budget_sub_amounting = budget_sub_amounting;
          }
          public String getC_field1() {
          	return c_field1;
          }
          public void setC_field1(String c_field1) {
          	this.c_field1 = c_field1;
          }
          public String getC_field2() {
          	return c_field2;
          }
          public void setC_field2(String c_field2) {
          	this.c_field2 = c_field2;
          }
          public String getC_field3() {
          	return c_field3;
          }
          public void setC_field3(String c_field3) {
          	this.c_field3 = c_field3;
          }
          public String getC_field4() {
          	return c_field4;
          }
          public void setC_field4(String c_field4) {
          	this.c_field4 = c_field4;
          }
          public String getC_field5() {
          	return c_field5;
          }
          public void setC_field5(String c_field5) {
          	this.c_field5 = c_field5;
          }
          public Timestamp getCreate_date() {
          	return create_date;
          }
          public void setCreate_date(Timestamp create_date) {
          	this.create_date = create_date;
          }
          public long getCreate_user() {
          	return create_user;
          }
          public void setCreate_user(long create_user) {
          	this.create_user = create_user;
          }
          public long getEle_hold1_id() {
          	return ele_hold1_id;
          }
          public void setEle_hold1_id(long ele_hold1_id) {
          	this.ele_hold1_id = ele_hold1_id;
          }
          public long getEle_hold10_id() {
          	return ele_hold10_id;
          }
          public void setEle_hold10_id(long ele_hold10_id) {
          	this.ele_hold10_id = ele_hold10_id;
          }
          public long getEle_hold2_id() {
          	return ele_hold2_id;
          }
          public void setEle_hold2_id(long ele_hold2_id) {
          	this.ele_hold2_id = ele_hold2_id;
          }
          public long getEle_hold3_id() {
          	return ele_hold3_id;
          }
          public void setEle_hold3_id(long ele_hold3_id) {
          	this.ele_hold3_id = ele_hold3_id;
          }
          public long getEle_hold4_id() {
          	return ele_hold4_id;
          }
          public void setEle_hold4_id(long ele_hold4_id) {
          	this.ele_hold4_id = ele_hold4_id;
          }
          public long getEle_hold5_id() {
          	return ele_hold5_id;
          }
          public void setEle_hold5_id(long ele_hold5_id) {
          	this.ele_hold5_id = ele_hold5_id;
          }
          public long getEle_hold6_id() {
          	return ele_hold6_id;
          }
          public void setEle_hold6_id(long ele_hold6_id) {
          	this.ele_hold6_id = ele_hold6_id;
          }
          public long getEle_hold7_id() {
          	return ele_hold7_id;
          }
          public void setEle_hold7_id(long ele_hold7_id) {
          	this.ele_hold7_id = ele_hold7_id;
          }
          public long getEle_hold8_id() {
          	return ele_hold8_id;
          }
          public void setEle_hold8_id(long ele_hold8_id) {
          	this.ele_hold8_id = ele_hold8_id;
          }
          public long getEle_hold9_id() {
          	return ele_hold9_id;
          }
          public void setEle_hold9_id(long ele_hold9_id) {
          	this.ele_hold9_id = ele_hold9_id;
          }
          public String getEle_str() {
          	return ele_str;
          }
          public void setEle_str(String ele_str) {
          	this.ele_str = ele_str;
          }
          public long getExp_eco_id() {
          	return exp_eco_id;
          }
          public void setExp_eco_id(long exp_eco_id) {
          	this.exp_eco_id = exp_eco_id;
          }
          public long getExp_func_id() {
          	return exp_func_id;
          }
          public void setExp_func_id(long exp_func_id) {
          	this.exp_func_id = exp_func_id;
          }
          public long getFinancing_type_id() {
          	return financing_type_id;
          }
          public void setFinancing_type_id(long financing_type_id) {
          	this.financing_type_id = financing_type_id;
          }
          public long getIn_mof_dep_id() {
          	return in_mof_dep_id;
          }
          public void setIn_mof_dep_id(long in_mof_dep_id) {
          	this.in_mof_dep_id = in_mof_dep_id;
          }
          public long getIn_ps_agency_id() {
          	return in_ps_agency_id;
          }
          public void setIn_ps_agency_id(long in_ps_agency_id) {
          	this.in_ps_agency_id = in_ps_agency_id;
          }
          public BigDecimal getInv_pay_amount() {
          	return inv_pay_amount;
          }
          public void setInv_pay_amount(BigDecimal inv_pay_amount) {
          	this.inv_pay_amount = inv_pay_amount;
          }
          public long getIs_assign() {
          	return is_assign;
          }
          public void setIs_assign(long is_assign) {
          	this.is_assign = is_assign;
          }
          public long getLast_ver() {
          	return last_ver;
          }
          public void setLast_ver(long last_ver) {
          	this.last_ver = last_ver;
          }
          public BigDecimal getModulate_add_amount() {
          	return modulate_add_amount;
          }
          public void setModulate_add_amount(BigDecimal modulate_add_amount) {
          	this.modulate_add_amount = modulate_add_amount;
          }
          public BigDecimal getModulate_add_amounting() {
          	return modulate_add_amounting;
          }
          public void setModulate_add_amounting(BigDecimal modulate_add_amounting) {
          	this.modulate_add_amounting = modulate_add_amounting;
          }
          public BigDecimal getModulate_sub_amount() {
          	return modulate_sub_amount;
          }
          public void setModulate_sub_amount(BigDecimal modulate_sub_amount) {
          	this.modulate_sub_amount = modulate_sub_amount;
          }
          public BigDecimal getModulate_sub_amounting() {
          	return modulate_sub_amounting;
          }
          public void setModulate_sub_amounting(BigDecimal modulate_sub_amounting) {
          	this.modulate_sub_amounting = modulate_sub_amounting;
          }
          public long getMof_dep_id() {
          	return mof_dep_id;
          }
          public void setMof_dep_id(long mof_dep_id) {
          	this.mof_dep_id = mof_dep_id;
          }
          public long getN_field1() {
          	return n_field1;
          }
          public void setN_field1(long n_field1) {
          	this.n_field1 = n_field1;
          }
          public long getN_field2() {
          	return n_field2;
          }
          public void setN_field2(long n_field2) {
          	this.n_field2 = n_field2;
          }
          public long getN_field3() {
          	return n_field3;
          }
          public void setN_field3(long n_field3) {
          	this.n_field3 = n_field3;
          }
          public long getN_field4() {
          	return n_field4;
          }
          public void setN_field4(long n_field4) {
          	this.n_field4 = n_field4;
          }
          public long getN_field5() {
          	return n_field5;
          }
          public void setN_field5(long n_field5) {
          	this.n_field5 = n_field5;
          }
          public BigDecimal getPay_amount() {
          	return pay_amount;
          }
          public void setPay_amount(BigDecimal pay_amount) {
          	this.pay_amount = pay_amount;
          }
          public long getPay_flag() {
          	return pay_flag;
          }
          public void setPay_flag(long pay_flag) {
          	this.pay_flag = pay_flag;
          }
          public String getPfs_detail_content() {
          	return pfs_detail_content;
          }
          public void setPfs_detail_content(String pfs_detail_content) {
          	this.pfs_detail_content = pfs_detail_content;
          }
          public long getPrj_budget_kind_id() {
          	return prj_budget_kind_id;
          }
          public void setPrj_budget_kind_id(long prj_budget_kind_id) {
          	this.prj_budget_kind_id = prj_budget_kind_id;
          }
          public long getPrj_budget_type_id() {
          	return prj_budget_type_id;
          }
          public void setPrj_budget_type_id(long prj_budget_type_id) {
          	this.prj_budget_type_id = prj_budget_type_id;
          }
          public String getPrj_code() {
          	return prj_code;
          }
          public void setPrj_code(String prj_code) {
          	this.prj_code = prj_code;
          }
          public long getPrj_std_id() {
          	return prj_std_id;
          }
          public void setPrj_std_id(long prj_std_id) {
          	this.prj_std_id = prj_std_id;
          }
          public long getPs_pfs_id() {
          	return ps_pfs_id;
          }
          public void setPs_pfs_id(long ps_pfs_id) {
          	this.ps_pfs_id = ps_pfs_id;
          }
          public long getPuritem_id() {
          	return puritem_id;
          }
          public void setPuritem_id(long puritem_id) {
          	this.puritem_id = puritem_id;
          }
          public BigDecimal getQuota_amount() {
          	return quota_amount;
          }
          public void setQuota_amount(BigDecimal quota_amount) {
          	this.quota_amount = quota_amount;
          }
          public BigDecimal getQuota_back_amount() {
          	return quota_back_amount;
          }
          public void setQuota_back_amount(BigDecimal quota_back_amount) {
          	this.quota_back_amount = quota_back_amount;
          }
          public long getQuota_level_id() {
          	return quota_level_id;
          }
          public void setQuota_level_id(long quota_level_id) {
          	this.quota_level_id = quota_level_id;
          }
          public long getRcid() {
          	return rcid;
          }
          public void setRcid(long rcid) {
          	this.rcid = rcid;
          }
          public long getStock_flag() {
          	return stock_flag;
          }
          public void setStock_flag(long stock_flag) {
          	this.stock_flag = stock_flag;
          }
          public BigDecimal getStock_plan_amount() {
          	return stock_plan_amount;
          }
          public void setStock_plan_amount(BigDecimal stock_plan_amount) {
          	this.stock_plan_amount = stock_plan_amount;
          }
          public long getSurplus_flag() {
          	return surplus_flag;
          }
          public void setSurplus_flag(long surplus_flag) {
          	this.surplus_flag = surplus_flag;
          }
          public long getYear() {
          	return year;
          }
          public void setYear(long year) {
          	this.year = year;
          }

}
