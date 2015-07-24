using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Appoxee.Asyncs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appoxee.asyncs']/class[@name='initAsync']"
	[global::Android.Runtime.Register ("com/appoxee/asyncs/initAsync", DoNotGenerateAcw=true)]
	public partial class InitAsync : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/appoxee/asyncs/initAsync", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InitAsync); }
		}

		protected InitAsync (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appoxee.asyncs']/class[@name='initAsync']/constructor[@name='initAsync' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "")]
		public unsafe InitAsync (global::Android.Content.Context p0, string p1, string p2, string p3, bool p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (InitAsync)) {
					SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", __args),
						JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V");
				SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z, __args),
					JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appoxee.asyncs']/class[@name='initAsync']/constructor[@name='initAsync' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='boolean'] and parameter[6][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;)V", "")]
		public unsafe InitAsync (global::Android.Content.Context p0, string p1, string p2, string p3, bool p4, string p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				if (GetType () != typeof (InitAsync)) {
					SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;)V", __args),
						JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLjava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;)V");
				SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLjava_lang_String_, __args),
					JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLjava_lang_String_Lcom_appoxee_AppoxeeObserver_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appoxee.asyncs']/class[@name='initAsync']/constructor[@name='initAsync' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='boolean'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='com.appoxee.AppoxeeObserver']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;Lcom/appoxee/AppoxeeObserver;)V", "")]
		public unsafe InitAsync (global::Android.Content.Context p0, string p1, string p2, string p3, bool p4, string p5, global::Appoxee.IAppoxeeObserver p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				if (GetType () != typeof (InitAsync)) {
					SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;Lcom/appoxee/AppoxeeObserver;)V", __args),
						JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;Lcom/appoxee/AppoxeeObserver;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLjava_lang_String_Lcom_appoxee_AppoxeeObserver_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLjava_lang_String_Lcom_appoxee_AppoxeeObserver_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;Lcom/appoxee/AppoxeeObserver;)V");
				SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLjava_lang_String_Lcom_appoxee_AppoxeeObserver_, __args),
					JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLjava_lang_String_Lcom_appoxee_AppoxeeObserver_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_appoxee_AppoxeeObserver_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appoxee.asyncs']/class[@name='initAsync']/constructor[@name='initAsync' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='boolean'] and parameter[6][@type='com.appoxee.AppoxeeObserver']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLcom/appoxee/AppoxeeObserver;)V", "")]
		public unsafe InitAsync (global::Android.Content.Context p0, string p1, string p2, string p3, bool p4, global::Appoxee.IAppoxeeObserver p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				if (GetType () != typeof (InitAsync)) {
					SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLcom/appoxee/AppoxeeObserver;)V", __args),
						JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLcom/appoxee/AppoxeeObserver;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_appoxee_AppoxeeObserver_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_appoxee_AppoxeeObserver_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLcom/appoxee/AppoxeeObserver;)V");
				SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_appoxee_AppoxeeObserver_, __args),
					JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_appoxee_AppoxeeObserver_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_doInBackground_arrayLjava_lang_Void_;
		#pragma warning disable 0169
		static Delegate GetDoInBackground_arrayLjava_lang_Void_Handler ()
		{
			if (cb_doInBackground_arrayLjava_lang_Void_ == null)
				cb_doInBackground_arrayLjava_lang_Void_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Void_);
			return cb_doInBackground_arrayLjava_lang_Void_;
		}

		static IntPtr n_DoInBackground_arrayLjava_lang_Void_ (IntPtr jnienv, IntPtr native__this, IntPtr native__params)
		{
			global::Appoxee.Asyncs.InitAsync __this = global::Java.Lang.Object.GetObject<global::Appoxee.Asyncs.InitAsync> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Void[] @params = (global::Java.Lang.Void[]) JNIEnv.GetArray (native__params, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Void));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (@params));
			if (@params != null)
				JNIEnv.CopyArray (@params, native__params);
			return __ret;
		}
		#pragma warning restore 0169

		static IntPtr id_doInBackground_arrayLjava_lang_Void_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appoxee.asyncs']/class[@name='initAsync']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Void...']]"
		[Register ("doInBackground", "([Ljava/lang/Void;)Ljava/lang/Void;", "GetDoInBackground_arrayLjava_lang_Void_Handler")]
		protected virtual unsafe global::Java.Lang.Void DoInBackground (params global:: Java.Lang.Void[] @params)
		{
			if (id_doInBackground_arrayLjava_lang_Void_ == IntPtr.Zero)
				id_doInBackground_arrayLjava_lang_Void_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Void;)Ljava/lang/Void;");
			IntPtr native__params = JNIEnv.NewArray (@params);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__params);

				global::Java.Lang.Void __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLjava_lang_Void_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/Void;)Ljava/lang/Void;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (@params != null) {
					JNIEnv.CopyArray (native__params, @params);
					JNIEnv.DeleteLocalRef (native__params);
				}
			}
		}

		static Delegate cb_onPostExecute_Ljava_lang_Void_;
		#pragma warning disable 0169
		static Delegate GetOnPostExecute_Ljava_lang_Void_Handler ()
		{
			if (cb_onPostExecute_Ljava_lang_Void_ == null)
				cb_onPostExecute_Ljava_lang_Void_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Ljava_lang_Void_);
			return cb_onPostExecute_Ljava_lang_Void_;
		}

		static void n_OnPostExecute_Ljava_lang_Void_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			global::Appoxee.Asyncs.InitAsync __this = global::Java.Lang.Object.GetObject<global::Appoxee.Asyncs.InitAsync> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Void result = global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.OnPostExecute (result);
		}
		#pragma warning restore 0169

		static IntPtr id_onPostExecute_Ljava_lang_Void_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appoxee.asyncs']/class[@name='initAsync']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='java.lang.Void']]"
		[Register ("onPostExecute", "(Ljava/lang/Void;)V", "GetOnPostExecute_Ljava_lang_Void_Handler")]
		protected virtual unsafe void OnPostExecute (global::Java.Lang.Void result)
		{
			if (id_onPostExecute_Ljava_lang_Void_ == IntPtr.Zero)
				id_onPostExecute_Ljava_lang_Void_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Ljava/lang/Void;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (result);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPostExecute_Ljava_lang_Void_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "(Ljava/lang/Void;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_execute_arrayLjava_lang_Void_;
		[Android.Runtime.Register("execute", "([Ljava/lang/Object;)Landroid/os/AsyncTask;", "")]
		public virtual unsafe global::Android.OS.AsyncTask Execute (params global:: Java.Lang.Void[] @params)
		{
			if (id_execute_arrayLjava_lang_Void_ == IntPtr.Zero)
				id_execute_arrayLjava_lang_Void_ = JNIEnv.GetMethodID (class_ref, "execute", "([Ljava/lang/Object;)Landroid/os/AsyncTask;");
			IntPtr native__params = JNIEnv.NewArray (@params);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__params);

				global::Android.OS.AsyncTask __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.AsyncTask> (JNIEnv.CallObjectMethod  (Handle, id_execute_arrayLjava_lang_Void_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.AsyncTask> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "([Ljava/lang/Object;)Landroid/os/AsyncTask;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (@params != null) {
					JNIEnv.CopyArray (native__params, @params);
					JNIEnv.DeleteLocalRef (native__params);
				}
			}
		}
	}
}
