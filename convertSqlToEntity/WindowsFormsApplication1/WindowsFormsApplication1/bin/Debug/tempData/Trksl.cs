using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grp.budget.ps.model
{
    [Serializable]
    public class Trksl
    {
          //单据类型
          private long bill_type_id;
          //创建日期
          private DateTime create_date;
          //创建人
          private long create_user;
          //创建人名称
          private string create_user_name;
          //指标文号
          private string doc_no_name;
          //功能科目ID
          private long exp_func_id;
          //主键
          private long id;
          //类别
          private long kind;
          //最后操作日期
          private DateTime last_op_date;
          //最后操作人
          private long last_op_user;
          //最后操作人名称
          private string last_op_user_name;
          //版本号
          private long last_ver;
          //流转单
          private long modulate_bill_id;
          //项目名称
          private string name;
          //金额
          private decimal pfs_amount;
          //预算类型id
          private long prj_budget_type_id;
          //调入预算明细ID
          private long ps_pfs_id;
          private long rcid;
          //指标id
          private long tran_id;

          public long Bill_type_id
          {
          	get { return bill_type_id; }
          	set { bill_type_id = value; }
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
          public string Create_user_name
          {
          	get { return create_user_name; }
          	set { create_user_name = value; }
          }
          public string Doc_no_name
          {
          	get { return doc_no_name; }
          	set { doc_no_name = value; }
          }
          public long Exp_func_id
          {
          	get { return exp_func_id; }
          	set { exp_func_id = value; }
          }
          public long Id
          {
          	get { return id; }
          	set { id = value; }
          }
          public long Kind
          {
          	get { return kind; }
          	set { kind = value; }
          }
          public DateTime Last_op_date
          {
          	get { return last_op_date; }
          	set { last_op_date = value; }
          }
          public long Last_op_user
          {
          	get { return last_op_user; }
          	set { last_op_user = value; }
          }
          public string Last_op_user_name
          {
          	get { return last_op_user_name; }
          	set { last_op_user_name = value; }
          }
          public long Last_ver
          {
          	get { return last_ver; }
          	set { last_ver = value; }
          }
          public long Modulate_bill_id
          {
          	get { return modulate_bill_id; }
          	set { modulate_bill_id = value; }
          }
          public string Name
          {
          	get { return name; }
          	set { name = value; }
          }
          public decimal Pfs_amount
          {
          	get { return pfs_amount; }
          	set { pfs_amount = value; }
          }
          public long Prj_budget_type_id
          {
          	get { return prj_budget_type_id; }
          	set { prj_budget_type_id = value; }
          }
          public long Ps_pfs_id
          {
          	get { return ps_pfs_id; }
          	set { ps_pfs_id = value; }
          }
          public long Rcid
          {
          	get { return rcid; }
          	set { rcid = value; }
          }
          public long Tran_id
          {
          	get { return tran_id; }
          	set { tran_id = value; }
          }

	}
}

